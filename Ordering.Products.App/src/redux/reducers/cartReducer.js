import Item1 from '../../images/laptop_1.jpg'
import Item2 from '../../images/laptop_2.jpg'
import Item3 from '../../images/laptop_3.jpg'
import Item4 from '../../images/laptop_4.jpg'
import Item5 from '../../images/laptop_5.jpg'
import Item6 from '../../images/laptop_6.jpg'
import Item7 from '../../images/laptop_7.jpg'
import Item8 from '../../images/laptop_8.jpg'
import Item9 from '../../images/laptop_9.jpg'
import Item10 from '../../images/laptop_10.jpg'
import Item11 from '../../images/laptop_11.jpg'
import Item12 from '../../images/laptop_12.jpg'
import Item13 from '../../images/laptop_5.jpg'
import Item14 from '../../images/laptop_6.jpg'
import Item15 from '../../images/laptop_7.jpg'
import Item16 from '../../images/laptop_8.jpg'
import Item17 from '../../images/laptop_9.jpg'
import Item18 from '../../images/laptop_10.jpg'
import Item20 from '../../images/laptop_11.jpg'
import Item21 from '../../images/laptop_12.jpg'
import {setProduct, getProduct,removeProduct, clearAll} from '../../service/ProductStorage';
import {getAllProducts,getProductsById} from '../../service/ServiceApi/ProductService';
import { ADD_TO_CART,REMOVE_ITEM,SUB_QUANTITY,ADD_QUANTITY,ADD_DELIVERY } from '../actions/action-types/cart-actions'

const initState = {
    items: [
        {id:1,img:Item1},
        {id:2,img: Item2},
        {id:3,img: Item3},
        {id:4,img:Item4},
        {id:5,img: Item5},
        {id:6,img: Item6},
        {id:7,img:Item7},
        {id:8,img: Item8},
        {id:9,img: Item9},
        {id:10,img:Item10},
        {id:11,img: Item11},
        {id:12,img: Item12},
        {id:6,img: Item13},
        {id:7,img:Item14},
        {id:8,img: Item15},
        {id:9,img: Item16},
        {id:10,img:Item17},
        {id:11,img: Item18},
        {id:12,img: Item20}
    ],
    addedItems:[],
    total: 0

}
const cartReducer= (state = initState,action)=>{
   
    //INSIDE HOME COMPONENT
    if(action.type === ADD_TO_CART){
          let addedItem = state.items.find(item=> item.id === action.id)
          //check if the action id exists in the addedItems
         let existed_item= state.addedItems.find(item=> action.id === item.id)
         if(existed_item)
         {
            addedItem.quantity += 1 
            setProduct({
                ...state,
                addedItems: [...state.addedItems],
                total: state.total + addedItem.price 
            })
             return{
                ...state,
                 total: state.total + addedItem.price 
                  }
        }
         else{
            addedItem.quantity = 1;
            //calculating the total
            let newTotal = state.total + addedItem.price 
            setProduct({
                ...state,
                addedItems: [...state.addedItems, addedItem],
                total : newTotal
            })

            return{
                ...state,
                addedItems: [...state.addedItems, addedItem],
                total : newTotal
            }
            
        }
    }
    if(action.type === REMOVE_ITEM){
        let itemToRemove= state.addedItems.find(item=> action.id === item.id)
        let new_items = state.addedItems.filter(item=> action.id !== item.id)

        let addedItemsArray = getProduct().addedItems;
        let updatedArray = [];
        let addedItem = state.items.find(item=> item.id === action.id);
        let itemTobeDelete = addedItemsArray.find(item => item.id == item.id);
        let index = [...state.addedItems].indexOf(itemTobeDelete);
        addedItemsArray.forEach(element => {
            if(element != itemTobeDelete){
                updatedArray.push(element);
            }
        });
        [...addedItemsArray].splice(index, 1)
        setProduct({
            ...state,
            addedItems: [...updatedArray],
            total: getProduct().total - (itemTobeDelete.price * itemTobeDelete.quantity ) 
        })

        //calculating the total
        let newTotal = state.total - (itemTobeDelete.price * itemTobeDelete.quantity )
        // console.log(itemToRemove)
        return{
            ...state,
            addedItems: new_items,
            total: newTotal
        }
    }
    //INSIDE CART COMPONENT
    if(action.type=== ADD_QUANTITY){
        let addedItem = state.items.find(item=> item.id === action.id)
        let updatedArray = [];
        let addedItemsArray = getProduct().addedItems;
        let itemTobeAdded = addedItemsArray.find(item => item.id == item.id);
       
         itemTobeAdded.quantity += 1 
          let newTotal = getProduct().total + itemTobeAdded.price
          addedItemsArray.forEach(element => {
            if(element == itemTobeAdded){
                element.quantity +=1;
                updatedArray.push(element);
            }else{
                updatedArray.push(element);
            }
        });
          setProduct({
            ...state,
            addedItems: [...updatedArray],
            total: newTotal
        })
          return{
              ...state,
              total: newTotal
          }
    }
    if(action.type=== SUB_QUANTITY){  
        let addedItem = state.items.find(item=> item.id === action.id) 
        //if the qt == 0 then it should be removed
        let updatedArray = [];
        if(addedItem.quantity === 1){
            let new_items = state.addedItems.filter(item=>item.id !== action.id)
            let newTotal = state.total - addedItem.price
            return{
                ...state,
                addedItems: new_items,
                total: newTotal
            }
        }
        else {
            let addedItemsArray = getProduct().addedItems;
        let itemTobeMinus = addedItemsArray.find(item => item.id == item.id);

          let newTotal = getProduct().total - itemTobeMinus.price
          addedItemsArray.forEach(element => {
            if(element == itemTobeMinus){
                element.quantity -=1;
                updatedArray.push(element);
            }else{
                updatedArray.push(element);
            }
        });
          setProduct({
            ...state,
            addedItems: [...updatedArray],
            total: newTotal
        })

            return{
                ...state,
                total: newTotal
            }
        }
        
    }

    if(action.type=== ADD_DELIVERY){
          return{
              ...state,
              total: state.total + 6
          }
    }

    if(action.type=== 'SUB_DELIVERY'){
        return{
            ...state,
            total: state.total - 6
        }
  }
    
  else{
    return state
    }
    
}

export default cartReducer
