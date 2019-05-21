import * as React from 'react';
import { connect } from 'react-redux';
import { Container, Row, Col } from "reactstrap";
import { IAppState } from '../store';
import { createBrowserHistory } from 'history'
import { StyleSheet, css } from 'aphrodite';

import { IPhone } from '../reducers/phoneReducer';

const styles = StyleSheet.create({
    tableHeader: {
        fontSize: 24,
        lineHeight: '1.0em',
        fontWeight: 'bold',
        paddingBottom: '20px'
    },
    tableRow: {
        verticalAlign: 'baseline',
        borderBottom: 'outset',
        paddingTop: '10px',
        paddingBottom: '10px',
    },
    textRight: {
        textAlign: 'right'
    },
});

interface IProps {
    phones: IPhone[];
}

class PhoneList extends React.Component<IProps> {

    public render() {
        var history = createBrowserHistory();
        const { phones } = this.props;
        return (
            <div className="name-container" >
                <Row className={css(styles.tableHeader)}>
                    <Col key="header.model">
                        MODEL
                    </Col>
                    <Col key="header.operativeSystemName">
                        OS
                    </Col>
                    <Col key="header.manufacturerName">
                        BY
                    </Col>
                    <Col key="header.year">
                        YEAR
                    </Col>
                    <Col key="header.ram">
                        RAM
                    </Col>
                    <Col key="header.storage">
                        STORAGE
                    </Col>
                    <Col key="header.price">
                        PRICE
                    </Col>
                </Row>
                {
                    phones &&
                        phones.map(phone => {
                            return (
                                <Container>
                                    <Row key="phone.phoneid" className={css(styles.tableRow)}>
                                        <Col key="phone.model">
                                            {phone.model}
                                        </Col>
                                        <Col key="phone.operativeSystemName">
                                            {phone.operativeSystemName}
                                        </Col>
                                        <Col key="phone.manufacturerName">
                                            {phone.manufacturerName}
                                        </Col>
                                        <Col key="phone.year">
                                            {phone.year}
                                        </Col>
                                        <Col key="phone.ram">
                                            {phone.ram}
                                        </Col>
                                        <Col key="phone.storage">
                                            {phone.storage}
                                        </Col>
                                        <Col key="phone.price">
                                            <Row>
                                                <Col className={css(styles.textRight)}>{phone.price}</Col>
                                                <Col><button className="btn btn-light" onClick={() => history.push('/PhoneDetail/' + phone.phoneId)}>Detail</button></Col>
                                            </Row>
                                        </Col>
                                    </Row>
                                </Container>
                            );
                        })
                }
            </div>
        );
    }
}
const mapStateToProps = (store: IAppState) => {
    return {
        phones: store.phoneState.phones,
    };
};

export default connect(mapStateToProps)(PhoneList);