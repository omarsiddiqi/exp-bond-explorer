import * as React from 'react';
import { Menu, Segment } from 'semantic-ui-react'
import { Link } from 'react-router';

export class NavMenu extends React.Component<void, void> {

    public render() {
        return  <Menu>
        <Menu.Item>
          Editorials
        </Menu.Item>

        <Menu.Item>
          Reviews
        </Menu.Item>

        <Menu.Item>
          Upcoming Events
        </Menu.Item>
      </Menu>
    }
}
