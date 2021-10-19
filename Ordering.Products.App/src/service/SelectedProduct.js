
export function setSelectedProduct(data){
    localStorage.setItem('selectedProduct', JSON.stringify(data));
}


export function getSelectedProduct() {
  // getter
  return JSON.parse(localStorage.getItem("selectedProduct"));
}

export function removeProduct() {
   // remove
   localStorage.removeSelectedProduct("selectedProduct");
 }

 export function clearSelectedProducts(){
    // remove all
    localStorage.removeItem("selectedProduct");
 }
