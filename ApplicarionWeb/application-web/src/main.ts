import 'primevue/resources/themes/lara-light-teal/theme.css'
import 'primeflex/primeflex.css'

import PrimeVue from 'primevue/config'
import { createApp } from 'vue'
import router from './router'
import App from './App.vue'


const app = createApp(App)

app.use(router)
app.use(PrimeVue)

app.mount('#app')
