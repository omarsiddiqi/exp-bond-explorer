import * as React from 'react';
import { Menu, Segment, Container, Divider, Header, Icon, Statistic, Label, List, Button } from 'semantic-ui-react'

export class NavMenu extends React.Component<{}, {}> {

    public render() {
        return <Menu size='massive' stackable color='blue' inverted attached='top' secondary>
                   <Container>
                       <Menu.Item header className='ui fluid'>EXPANSE</Menu.Item>

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
               </Menu>;
    }
}
