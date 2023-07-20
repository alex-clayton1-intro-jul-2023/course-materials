- Tailwind
	- `npm install -D tailwindcss postcss autoprefixer @tailwindcss/forms @tailwindcss/typography daisyui
	- `npx tailwindcss init` This creates the 
	- What it does:
		- Normalizes all headers to same size
		- Adds classes
	- TODO FOR IT 
		- Make sure to fill in style.css
		- Make sure to add it to style.css under plugins
		- Make sure to add data-theme under index.html
- *TAILWIND CONFIG FILE*
	- const daisyui = require('daisyui');

  

/** @type {import('tailwindcss').Config} */

module.exports = {

  content: [

    "./src/**/*.{html,ts}",

  ],

  theme: {

    extend: {},

  },

  plugins: [

    require('@tailwindcss/forms'),

    require('@tailwindcss/typography'),

    require('daisyui')

  ],

  daisyui: {

    themes: ["aqua", "cupcake", "cyberpunk"]

  }

}

