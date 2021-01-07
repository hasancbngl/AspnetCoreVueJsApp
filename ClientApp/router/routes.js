import CounterExample from 'components/counter-example'
import FetchData from 'components/fetch-data'
import HomePage from 'components/home-page'
import Register from 'components/register'
import About from 'components/about'
import test from 'components/test'
import myData from 'components/myData'
import Login from 'components/login'

export const routes = [
   { name: 'register', path: '/', component: Register, display: 'Home', icon: 'home'},
  { name: 'homePage', path: '/home-page', component: HomePage, display: 'Home Starter', icon: 'home'},
  { name: 'about', path: '/about', component: About, display: 'About Template', icon: 'info' },
  { name: 'counter', path: '/counter', component: CounterExample, display: 'Counter', icon: 'graduation-cap' },
  { name: 'fetch-data', path: '/fetch-data', component: FetchData, display: 'Data', icon: 'list' },
  { name: 'test', path: '/test', component: test, display: 'Test', icon: '' },
  { name: 'data', path: '/myData', component: myData, display: 'My Data', icon: 'envelope' },
  { name: 'login', path: '/login', component: Login,  },
]
