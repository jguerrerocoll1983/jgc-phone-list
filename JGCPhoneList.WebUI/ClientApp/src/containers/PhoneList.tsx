import * as React from 'react';
import { connect } from 'react-redux';
import { Container, Row, Col } from "reactstrap";

import { IAppState } from '../store';

import { IPhone } from '../reducers/phoneReducer';

interface IProps {
    phones: IPhone[];
}

class PhoneList extends React.Component<IProps> {
    handleClick(e: number) {
        console.log('this is: ' + e);
    }

    public render() {
        const { phones } = this.props;
        return (
            <div className="name-container" >
                {
                    phones &&
                        phones.map(phone => {
                            return (
                                <Container>
                                    <Row key="phone.phoneid" onClick={() => this.handleClick(phone.phoneId)}>
                                        <Col>
                                            {phone.model}
                                        </Col>
                                        <Col>
                                            {phone.year}
                                        </Col>
                                        <Col>
                                            {phone.manufacturerName}
                                        </Col>
                                        <Col>
                                            {phone.year}
                                        </Col>
                                        <Col>
                                            {phone.ram}
                                        </Col>
                                        <Col>
                                            {phone.storage}
                                        </Col>
                                        <Col>
                                            {phone.price}
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