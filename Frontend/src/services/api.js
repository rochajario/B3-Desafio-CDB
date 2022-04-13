import Axios from 'axios'
const BASE_URL = "https://localhost:5001"

export default class ApiService {

    calculateInvestment(investmentDto) {
        return Axios.post(`${BASE_URL}/api/Investment/CDB`, investmentDto);
    }
}