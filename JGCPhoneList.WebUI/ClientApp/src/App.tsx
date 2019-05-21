import React from 'react';
import { BrowserRouter, Switch, Route } from 'react-router-dom'

import Layout from './components/Layout';
import Home from './components/Home';
import PhoneList from './containers/PhoneList';
import PhoneDetail from './containers/PhoneDetail';

const App: React.SFC<{}> = () => {
    return (
        <>
            <BrowserRouter>
                <Layout>
                    <Switch>
                        <Route exact path='/' component={Home} />
                        <Route path='/Phones' component={PhoneList} />
                        <Route exact path="/Phones/:phoneId" component={PhoneDetail} />
                    </Switch>
                </Layout>
            </BrowserRouter>
        </>
    );
};

export default App;