import axios from "axios";
import BASE_URL from "../../AppSettings";

export const getAllProducts = () => {
  (async () => {
    const rawResponse = fetch(BASE_URL+"/Products", {
      method: "GET",
      headers: {
        Accept: "application/json",
        "Content-Type": "application/json",
      },
      body: JSON.stringify(),
    }).catch(err => {
        return new Error(err)
      });
    const content = rawResponse;
    return content;
  })();
};


export const getProductsById  = (id) => {
    (async () => {
      const rawResponse = await fetch(BASE_URL + "​/Products", {
        method: "GET",
        headers: {
          Accept: "application/json",
          "Content-Type": "application/json",
        },
        body: JSON.stringify({
         id : id
        }),
      });
      const content = await rawResponse.json();
      return content;
    })();
  };
