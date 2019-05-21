import * as React from 'react';
import { connect } from 'react-redux';
import { Container, Row, Col } from "reactstrap";
import { IAppState } from '../store';
import { createBrowserHistory } from 'history'
import { StyleSheet, css } from 'aphrodite';

import { IPhoneDetail } from '../reducers/phoneDetailReducer';


interface IProps {
    phoneDetail: IPhoneDetail;
}

class PhoneDetail extends React.Component<IProps> {

    public render() {
        const { phoneDetail } = this.props;

        return (
            <div className="name-container"></div>
        );
    }
}

const mapStateToProps = (store: IAppState) => {
    return {
        phones: store.phoneDetailState.phoneDetails,
    };
};

export default connect(mapStateToProps)(PhoneDetail);