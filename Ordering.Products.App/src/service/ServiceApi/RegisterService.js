import axios from "axios";
import BASE_URL from "../../AppSettings";

export const RegisterUser = (
  id,
  name,
  surname,
  email,
  password,
  isActive,
  addressType,
  streetAddress,
  suburb,
  cityTown,
  postalCode
) => {
  (async () => {
    const rawResponse = await fetch(BASE_URL + "​/Authenticate/register​", {
      method: "POST",
      headers: {
        Accept: "application/json",
        "Content-Type": "application/json",
      },
      body: JSON.stringify({
        id: id,
        name: name,
        surname: surname,
        email: email,
        password: password,
        isActive: isActive,
        addressType: addressType,
        streetAddress: streetAddress,
        suburb: suburb,
        cityTown: cityTown,
        postalCode: postalCode,
      }),
    });
    const content = await rawResponse.json();
    return content;
  })();
};

export const LoginUser = (
    email,
    password,
  ) => {
    (async () => {
      const rawResponse = await fetch(BASE_URL + "​/Authenticate/login", {
        method: "POST",
        headers: {
          Accept: "application/json",
          "Content-Type": "application/json",
        },
        body: JSON.stringify({
          email: email,
          password: password
        }),
      });
      const content = await rawResponse.json();
      return content;
    })();
  };
