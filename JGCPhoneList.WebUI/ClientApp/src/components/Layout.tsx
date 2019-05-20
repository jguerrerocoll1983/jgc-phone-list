
import React from 'react';
import { Container } from 'reactstrap';
import NavMenu from "./NavMenu";
import { INavProps, NavProps} from "./NavMenu";

export interface ILayoutProps {
    navProps: INavProps
}

export class LayoutProps implements ILayoutProps {
    navProps: INavProps = new NavProps();
}

export default function Layout(props : any) {
    return(
        <div>
            <NavMenu isOpen={true}/>
            <Container>
                {props.children}
            </Container>
        </div>);
}