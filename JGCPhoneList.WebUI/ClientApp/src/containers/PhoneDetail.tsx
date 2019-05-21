import * as React from 'react';
import { connect } from 'react-redux';
import { Container, Row, Col } from "reactstrap";
import { IAppState } from '../store';
import { createBrowserHistory } from 'history'
import { StyleSheet, css } from 'aphrodite';

import { IPhoneDetail } from '../reducers/phoneDetailReducer';


export interface IPhoneDetailProps {
    phoneId: string;
}

export interface IPhoneDetailState {
    phoneDetail: IPhoneDetail[];
}

class PhoneDetail extends React.Component<IPhoneDetailProps, IPhoneDetailState> {
    state = { phoneDetail: [] };
    public render() {

        return (
            <div className="name-container"></div>
        );
    }
}

const mapStateToProps = (store: IAppState) => {
    return {
        phones: store.phoneDetailState.phoneDetail,
    };
};

export default connect(mapStateToProps)(PhoneDetail);