import * as React from 'react';
import { connect } from 'react-redux'
import { render } from "react-dom";
import { Container, Row, Col } from "reactstrap";
import axios from "axios";

interface ServerResponse {
    data: ServerData[]
}

interface ServerData {
    Model : string,
    Description: string,
    Year: string,
    Weight: string,
    Battery: string,
    RAM: string,
    Storage: string,
    Resolution: string,
    Price: string,
}


axios.request<ServerData>({
    url: '/Api/Phones',
    transformResponse: (r: ServerResponse) => r.data
}).then((response) => {
    // `response` is of type `AxiosResponse<ServerData>
    console.log(response.data);
    const { data } = response;
    // `data` is of type ServerData, correctly inferred
});

export function Phones() {


    return (
        <div>
            <Container>
                <Row>
                    <Col sm>
                        One of three columns
                    </Col>
                    <Col sm>
                    </Col>
                    <Col sm>
                        One of three columns
                    </Col>
                </Row>
            </Container>
        </div>);
}

export default connect()(Phones);