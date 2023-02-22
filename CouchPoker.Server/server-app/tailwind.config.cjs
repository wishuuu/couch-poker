/** @type {import('tailwindcss').Config} */
module.exports = {
    content: [
        './src/**/*.html',
        './src/**/*.{js,ts,jsx,tsx,html}',
    ],
    theme: {
        extend: {},
    },
    plugins: [require("daisyui")],
}
