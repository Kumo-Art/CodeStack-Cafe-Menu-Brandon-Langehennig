// Write your JavaScript here.
//--------------------Fetch------------------------------
import { categoriesFetch, itemsFetch, restaurantFetch } from "./dataservices.js";  


//-------------------------grab elements----------------------------------------//

const restName1 = document.getElementById("restaurant-name");
const restName2 = document.getElementById("rest-name");



//-------------------------Functions----------------------------------------//

const restaurantName = async (id) => {
    
    const rest = await restaurantFetch(id);
    console.log(rest);

    
}