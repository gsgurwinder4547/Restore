import { createSlice } from "@reduxjs/toolkit";

const getInitialDarkMode = () => {
  const storeDarkMode = localStorage.getItem('darkMode');
  return storeDarkMode ? JSON.parse(storeDarkMode) : true
}

export const uiSlice = createSlice({
    name: 'ui',
    initialState: {
        isLoading: false,
        darkMode: getInitialDarkMode()
    },
    reducers: {
        startLoading: (state) => {
            state.isLoading = true;
        },
        stoptLoading: (state) => {
            state.isLoading = false;
        },
        setDarkMode: (state) => {
            localStorage.setItem('darkMode', JSON.stringify(!state.darkMode));
            state.darkMode = !state.darkMode
        }
    }
})

export const {startLoading, stoptLoading, setDarkMode} = uiSlice.actions;