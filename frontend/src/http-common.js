import Axios from 'axios';

const createAxios = Axios.create({
    baseURL: "http://localhost:5193"
})

export default createAxios;
