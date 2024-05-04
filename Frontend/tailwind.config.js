/** @type {import('tailwindcss').Config} */
export default {
  content: [
    "./index.html",
    "./src/**/**.jsx",
  ],

  theme: {
    extend: {
      //clases personalizadas
       colors: {
         "blue-ligth": "#697A98",
         "gray-blue": "#B8BFD6",
         "blue": "#19335A",
         "blue-trans": "#17407D"
         
       },
    },
  },
  plugins: [],
}


