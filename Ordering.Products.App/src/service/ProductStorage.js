
export function setProduct(data){
    localStorage.setItem('Product', JSON.stringify(data));
}


export function getProduct() {
  // getter
  return JSON.parse(localStorage.getItem("Product"));
}

export function removeProduct() {
   // remove
   localStorage.removeProduct("Product");
 }

 export function clearAll(){
    // remove all
    localStorage.removeItem("Product");
 }
