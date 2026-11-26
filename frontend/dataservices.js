const BASE_URL = "http://localhost:5092/api";


export const categoriesFetch = async (id) => {
      const res = await fetch(`${BASE_URL}/categories/getbyid/${id}`);
      console.log(res.status, res.ok);

      if(res.status === 404){
        throw new Error("No category with that Id found. Check console.")
      }

      if(!res.ok) {
        throw new Error(`Server errror: ${res.status}`);
      }

      return await res.json();
}

export const restaurantFetch = async (id) => {
      const res = await fetch(`${BASE_URL}/restaurant/getbyid/${id}`);
      console.log(res.status, res.ok);

      if(res.status === 404){
        throw new Error("No category with that Id found. Check console.")
      }

      if(!res.ok) {
        throw new Error(`Server errror: ${res.status}`);
      }

      return await res.json();
}

export const itemsFetch = async (id) => {
      const res = await fetch(`${BASE_URL}/items/getbyid/${id}`);
      console.log(res.status, res.ok);

      if(res.status === 404){
        throw new Error("No category with that Id found. Check console.")
      }

      if(!res.ok) {
        throw new Error(`Server errror: ${res.status}`);
      }

      return await res.json();
}