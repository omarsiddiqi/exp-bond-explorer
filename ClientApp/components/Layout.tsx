import * as React from 'react';
import { NavMenu } from './NavMenu';
import { Menu, Segment, Container, Divider, Header, Icon, Statistic, Label, List, Button } from 'semantic-ui-react'
import MarketOverviewContainer from './MarketOverview'
import FetchDataContainer from './FetchData'

export class Layout extends React.Component<{}, {}> {
    public render() {
        return <Container fluid>
            <NavMenu />
            <Divider hidden />
            <MarketOverviewContainer />
        </Container>;
    }
}
