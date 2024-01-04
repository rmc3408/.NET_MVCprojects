import axios, { AxiosError, AxiosResponse } from "axios";

axios.defaults.baseURL = "http://localhost:3001";
const responseData = (response: AxiosResponse) => response.data;

export const products = {
  getProducts: () => axios.get("/Product").then(responseData),
  getProduct: (id: string) => axios.get("/Product/"+ id).then(responseData)
}

const agent = {
  products
}

export default agent;