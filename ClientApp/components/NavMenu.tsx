import * as React from 'react';
import { Menu, Segment, Container, Divider, Header, Icon, Statistic, Label, List, Button } from 'semantic-ui-react'
import { Link } from 'react-router';

export class NavMenu extends React.Component<void, void> {

    public render() {
        return <Segment>
            <Menu size='massive' stackable color='blue' inverted attached='top' secondary>
                <Container>
                    <Menu.Item fluid header className='ui fluid'>EXPANSE</Menu.Item>

                    <Menu.Menu position='right'>
                        <div className='ui right aligned category search item'>
                            <div className='ui transparent icon input'>
                                <input className='prompt' type='text' placeholder='Search accounts...' />
                                <i className='search link icon' />
                            </div>
                            <div className='results'></div>
                        </div>
                    </Menu.Menu>
                </Container>
            </Menu>

            <Divider horizontal></Divider>

            <Container>
                <Segment basic secondary textAlign='center' padded='very'>
                    <Header color='blue' as='h2' icon>
                        <Icon name='area chart' />
                        Bond Explorer
                <Header.Subheader>
                            Your bond portfolio viewer
                </Header.Subheader>
                    </Header>
                </Segment>

                <Segment basic secondary textAlign='center' padded='very'>
                    <Header color='blue' as='h2'>
                        Overview
            </Header>
                    <Statistic.Group widths='4' size='small'>
                        <Statistic>
                            <Statistic.Value>6K</Statistic.Value>
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

                <Segment basic secondary textAlign='center' padded='very'>
                    <Header color='blue' as='h2'>
                        Your portfolio
            </Header>
                    <Statistic.Group widths='3' size='small'>
                        <Statistic>
                            <Statistic.Value>3</Statistic.Value>
                            <Statistic.Label color='blue'>Accounts</Statistic.Label>
                        </Statistic>
                        <Statistic>
                            <Statistic.Value>10</Statistic.Value>
                            <Statistic.Label>Bonds</Statistic.Label>
                        </Statistic>
                        <Statistic>
                            <Statistic.Value>200</Statistic.Value>
                            <Statistic.Label>EXP earned</Statistic.Label>
                        </Statistic>
                    </Statistic.Group>
                </Segment>

                <Segment basic secondary padded='very'>
                    <Header color='blue' as='h2' textAlign='center'>
                        Search results for Account 0x000123456
            </Header>
                    <Header textAlign='center'>
                        <Label color='orange'>3</Label> bonds found
            </Header>
                    <List divided relaxed>
                        <List.Item>
                            <List.Icon name='smile' size='large' verticalAlign='middle' />
                            <List.Content>
                                <List.Header as='a'>Next coupon payment of 100 EXP in 10 days</List.Header>
                                <List.List>
                                    <List.Item>Multiplier: <Label color='green'>100</Label></List.Item>
                                    <List.Item>Maturity: In <Label color='yellow'>2</Label> months</List.Item>
                                </List.List>
                            </List.Content>
                        </List.Item>
                        <List.Item>
                            <List.Icon name='smile' size='large' verticalAlign='middle' />
                            <List.Content>
                                <List.Header as='a'>Next coupon payment of 200 EXP in 15 days</List.Header>
                                <List.List>
                                    <List.Item>Multiplier: <Label color='green'>200</Label></List.Item>
                                    <List.Item>Maturity: In <Label color='yellow'>5</Label> months</List.Item>
                                </List.List>
                            </List.Content>
                        </List.Item>
                        <List.Item>
                            <List.Icon name='smile' size='large' verticalAlign='middle' />
                            <List.Content>
                                <List.Header as='a'>Next coupon payment of 50 EXP in 29 days</List.Header>
                                <List.List>
                                    <List.Item>Multiplier: <Label color='green'>50</Label></List.Item>
                                    <List.Item>Maturity: In <Label color='yellow'>1</Label> months</List.Item>
                                </List.List>
                            </List.Content>
                        </List.Item>
                    </List>
                    <Segment basic secondary textAlign='center'>
                        <Button primary>Add to portfolio</Button>
                    </Segment>
                </Segment>
            </Container>
        </Segment>
    }
}
