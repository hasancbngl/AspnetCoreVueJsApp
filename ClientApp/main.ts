import Vue from 'vue';
import App from './App.vue';
import router from './router';
import store from './store/store';
// import the main Sass manifest file
import '@/assets/sass/main.scss';
import axios from 'axios';

Vue.config.productionTip = false;

new Vue({
  router,
  store,
  render: (h: any) => h(App),
}).$mount('#app');;