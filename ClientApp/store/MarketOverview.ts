import { fetch, addTask } from 'domain-task';
import { Action, Reducer, ActionCreator } from 'redux';
import { AppThunkAction } from './';

// -----------------
// STATE - This defines the type of data maintained in the Redux store.

export interface MarketOverviewState {
    isLoading: boolean;
    input: number;
    marketOverview: MarketOverview;
}

export interface MarketOverview {
    totalBondsIssued: number;
    totalBondsAvailable: number;
    totalBondsBought: number;
    totalDistinctUsers: number;
    contractBalance: number;
}

// -----------------
// ACTIONS - These are serializable (hence replayable) descriptions of state transitions.
// They do not themselves have any side-effects; they just describe something that is going to happen.
// Use @typeName and isActionType for type detection that works even after serialization/deserialization.

interface RequestMarketOverviewAction {
    type: 'REQUEST_MARKET_OVERVIEW',
    input: number;
}
interface ReceiveMarketOverviewAction {
    type: 'RECEIVE_MARKET_OVERVIEW',
    input: number,
    marketOverview: MarketOverview;
}

// Declare a 'discriminated union' type. This guarantees that all references to 'type' properties contain one of the
// declared type strings (and not any other arbitrary string).
type KnownAction = RequestMarketOverviewAction | ReceiveMarketOverviewAction;

// ----------------
// ACTION CREATORS - These are functions exposed to UI components that will trigger a state transition.
// They don't directly mutate state, but they can have external side-effects (such as loading data).

export const actionCreators = {
    requestMarketOverview: (input: number): AppThunkAction<KnownAction> => (dispatch, getState) => {
        let fetchTask = fetch(` /api/Bond/TotalBonds?input=${ input } `)
            .then(response => response.json() as Promise<MarketOverview>)
            .then(data => {
                dispatch({ type: 'RECEIVE_MARKET_OVERVIEW', input: input, marketOverview: data });
            });

        addTask(fetchTask);
        dispatch({ type: 'REQUEST_MARKET_OVERVIEW', input: input });
    }
};

// ----------------
// REDUCER - For a given state and action, returns the new state. To support time travel, this must not mutate the old state.

const unloadedState: MarketOverviewState = {
    input: null,
    marketOverview: { totalBondsIssued: 0, totalBondsAvailable: 0, totalBondsBought: 0, totalDistinctUsers: 0, contractBalance: 0},
    isLoading: false
};

export const reducer: Reducer<MarketOverviewState> = (state: MarketOverviewState, action: KnownAction) => {
    switch (action.type) {
        case 'REQUEST_MARKET_OVERVIEW':
            return {
                input: action.input,
                marketOverview: state.marketOverview,
                isLoading: true
            };
        case 'RECEIVE_MARKET_OVERVIEW':
            return {
                input: action.input,
                marketOverview: action.marketOverview,
                isLoading: false
            };                           
        default:
            // The following line guarantees that every action in the KnownAction union has been covered by a case above
            const exhaustiveCheck: never = action;
    }

    // For unrecognized actions (or in cases where actions have no effect), must return the existing state
    //  (or default initial state if none was supplied)
    return state || unloadedState;
};
