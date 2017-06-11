import * as React from 'react';
import { Link, RouteComponentProps } from 'react-router-dom';
import { connect } from 'react-redux';
import { ApplicationState }  from '../store';
import * as MarketOverviewState from '../store/MarketOverview';
import { Menu, Segment, Container, Divider, Header, Icon, Statistic, Label, List, Button } from 'semantic-ui-react'

// At runtime, Redux will merge together...
type MarketOverviewProps =
    MarketOverviewState.MarketOverviewState // ... state we've requested from the Redux store
    & typeof MarketOverviewState.actionCreators;      // ... plus action creators we've requested    

class MarketOverview extends React.Component<MarketOverviewProps, {}> {
    componentWillMount() {
        // This method runs when the component is first added to the page
        this.props.requestMarketOverview(this.props.input);
    }

    componentWillReceiveProps(nextProps: MarketOverviewProps) {
        // This method runs when incoming props (e.g., route params) change
        //this.props.requestMarketOverview(nextProps.input);
    }

    public render() {
        return <Container>
                   <Segment basic secondary textAlign='center' padded='very'>
                       <Header color='blue' as='h2'>
                           Overview
                       </Header>
                       <Statistic.Group widths='4' size='small'>
                           <Statistic>
                               <Statistic.Value>{this.props.marketOverview.totalBondsIssued}</Statistic.Value>
                               <Statistic.Label color='blue'>Issued</Statistic.Label>
                           </Statistic>
                           <Statistic>
                               <Statistic.Value>73</Statistic.Value>
                               <Statistic.Label>Available</Statistic.Label>
                           </Statistic>
                           <Statistic>
                               <Statistic.Value>900K</Statistic.Value>
                               <Statistic.Label>Taken of market</Statistic.Label>
                           </Statistic>
                           <Statistic>
                               <Statistic.Value>120</Statistic.Value>
                               <Statistic.Label>Different users</Statistic.Label>
                           </Statistic>
                       </Statistic.Group>
                   </Segment>
               </Container>;
    }
}

export default connect(
    (state: ApplicationState) => state.marketOverview, // Selects which state properties are merged into the component's props
    MarketOverviewState.actionCreators                 // Selects which action creators are merged into the component's props
)(MarketOverview);
