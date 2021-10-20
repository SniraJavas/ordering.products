import axios from "axios";
import BASE_URL from "../../AppSettings";

export const getUserAllOrders = (
    userId
) => {
  (async () => {
    const rawResponse = await fetch(BASE_URL + "​/Orders", {
      method: "GET",
      headers: {
        Accept: "application/json",
        "Content-Type": "application/json",
      },
      body: JSON.stringify({
       userId : userId
      }),
    });
    const content = await rawResponse.json();
    return content;
  })();
};

export const getUserOrdersById = (userId, Id) => {
  (async () => {
    const rawResponse = await fetch(BASE_URL + "​/Orders", {
      method: "GET",
      headers: {
        Accept: "application/json",
        "Content-Type": "application/json",
      },
      body: JSON.stringify({
        userId: userId,
        Id: Id,
      }),
    });
    const content = await rawResponse.json();
    return content;
  })();
};

export const userOrder = ({
    id,
    userId,
    productId,
    total,
    active,
    dateCreated,
    status
  }) => {
    (async () => {
      const rawResponse = await fetch(BASE_URL + "​/Orders", {
        method: "POST",
        headers: {
          Accept: "application/json",
          "Content-Type": "application/json",
        },
        body: JSON.stringify({
            id : id,
            userId : userId,
            productId : productId,
            total : total,
            active : active,
            dateCreated : dateCreated,
            status : status
        }),
      });
      const content = await rawResponse.json();
      return content;
    })();
  };

  export const deleteOrder = ({
    userId, Id
  }) => {
    (async () => {
      const rawResponse = await fetch(BASE_URL + "​/Orders", {
        method: "DELETE",
        headers: {
          Accept: "application/json",
          "Content-Type": "application/json",
        },
        body: JSON.stringify({
            id : Id,
            userId : userId,
        }),
      });
      const content = await rawResponse.json();
      return content;
    })();
  };

  export const cancelOrder = ({
    userId, Id
  }) => {
    (async () => {
      const rawResponse = await fetch(BASE_URL + "​/Orders/Cancel", {
        method: "POST",
        headers: {
          Accept: "application/json",
          "Content-Type": "application/json",
        },
        body: JSON.stringify({
            id : Id,
            userId : userId,
        }),
      });
      const content = await rawResponse.json();
      return content;
    })();
  };
