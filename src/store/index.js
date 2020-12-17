import Vue from 'vue'
import Vuex from 'vuex'
import axios from 'axios'

Vue.use(Vuex)

/*
 * The authorization header is set for axios when you login but what happens when you come back or
 * the page is refreshed. When that happens you need to check for the token in local storage and if it
 * exists you should set the header so that it will be attached to each request
 */
const currentToken = localStorage.getItem('token')
const currentUser = JSON.parse(localStorage.getItem('user'));

if(currentToken != null) {
  axios.defaults.headers.common['Authorization'] = `Bearer ${currentToken}`;
}

export default new Vuex.Store({
  state: {
    //for doctor views
    workingOfficesInfo: [],
    workingOfficesReviews: [],
    doctorInfo: {},
    pendingAppointments: [],
    approvedAppointments: [],

    //for patient Views
    allOfficesInfo: [],
    allOfficesReviews: [],
    allDoctors: [],
    patientInfo: {},
    patientAppointments: [],

    //TODO add notification info

    //Static test values
    officesStatic: [
      { id:"69",
        name: "Tom's Office",
        phone:"123-4567",
        address:"123 Test Street",
        city: "New Test",
        state: "Pa",
        zip: 11221,
        image: require('../img/anime_hospital_1.png')
      },
      { id:"70",
        name: "Mayor Pauline's Office",
        phone:"867-5309",
        address:"1212 Boogiewoogie Avenue",
        address2: "Suite 31",
        city: "New Donk",
        state: "NY",
        zip: 90909,
        image: require('../img/Sogo_Hospital.png')
      }
    ],
    doctorInfoStatic: {
      userId: 5,
      hourlyRate: 40.00,
      firstName: "Luigi",
      lastName: "Mario",
      monday: { start: 9, end: 5 },
      tuesday: { start: 9, end: 5 },
      wednesday: { start: 9, end: 5 },
      thursday: { start: 9, end: 5 },
      friday: { start: 9, end: 5 },
    },
    pendingAppointmentsStatic: [
      {
        appointmentId: 10,
        patientUserName: "bunkman420",
        patientFirstName: "Bob",
        patientLastName: "Hoskins",
        patientDateOfBirth: "10/26/1942",
        patientPhone:"555-5555",
        patientEmail: "bunkman420@yahoo.com",
        apptDate: "1/1/2021",
        apptTime: '9:00',
        virtual: 0,
        message: "My leg!!!!!!!!!",
        status: "pending"
      },
      {
        appointmentId: 16,
        patientUserName: "xXScthytherKillerWeed420Xx",
        patientFirstName: "Tom",
        patientLastName: "Anderson",
        patientDateOfBirth: "1/1/1965",
        patientPhone:"555-1234",
        patientEmail: "breakitdown@hotmail.com",
        apptDate: "1/5/2021",
        apptTime: '12:00',
        virtual: 1,
        message: "Just messed my shit up",
        status: "pending"
      }
    ],
    approvedAppointmentsStatic: [
      {
        appointmentId: 2,
        patientUserName: "verycoolperson",
        patientFirstName: "Michelle",
        patientLastName: "Obama",
        apptDate: 1/16/2021,
        apptTime: '12:00',
        virtual: 0,
        message: "Don't tell Barry",
        status: "approved" 
      },
      {
        appointmentId: 11,
        patientUserName: "Th3Legend",
        patientFirstName: "Henry",
        patientLastName: "Edwards",
        apptDate: 2/1/2021,
        apptTime: '13:00',
        virtual: 0,
        message: "",
        status: "approved"
      }
    ],
    

    //Default Login Info
    token: currentToken || '',
    user: currentUser || {}
  },

  
  mutations: {
    SET_AUTH_TOKEN(state, token) {
      state.token = token;
      localStorage.setItem('token', token);
      axios.defaults.headers.common['Authorization'] = `Bearer ${token}`
    },
    SET_USER(state, user) {
      state.user = user;
      localStorage.setItem('user',JSON.stringify(user));
    },
    LOGOUT(state) {
      localStorage.removeItem('token');
      localStorage.removeItem('user');
      state.token = '';
      state.user = {};
      axios.defaults.headers.common = {};
    },
    SET_APPOINTMENTS(state, appointments){
      state.appointments = appointments;
     
    },
    SET_DOCTOR_INFO(state, doctor){
      state.doctor = doctor;
    }
  }
})
