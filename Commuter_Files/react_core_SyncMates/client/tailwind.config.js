/** @type {import('tailwindcss').Config} */
export default {
  content: ["./index.html", "./src/**/*.{js,ts,jsx,tsx}"],
  theme: {
    extend: {
      colors: {
        gr_1: "#FF018B",
        gr_2: "#DF01E9",
        black: "#1B1A1B",
        white: "#ffffff",
      },

      animation: {
        flip: 'flip 4s linear infinite',
      },

      keyframes: {
      flip: {
          "0%": { transform: "rotateY(0deg)" },
          "100%": { transform: "rotateY(360deg)" },
        },
      },
    },
  },
  plugins: [],
};
