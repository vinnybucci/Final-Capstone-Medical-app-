import axios from 'axios';

export default {
  GetMyInfo(userId) {
    return axios.get(`/doctor/${userId}`); //returns a doctor
  },

  UpdateMyInfo(doctor) {
    return axios.put('/doctor/myInfo/update', doctor);
  },

  GetMyOffices(userId) {
    return axios.get(`/doctor/${userId}/myOffices`); //returns array of offices
  },

  GetOfficeReviews(officeId) {
    return axios.get(`/doctor/myOffices/${officeId}`); //returns array of reviews
  },

  GetReviewResponses(office) {
    return axios.get(`/doctor/myOffices/${office.id}/reviews/responses`); //returns array of responses
  },

  GetAppointments(doctorId) {
    return axios.get(`/doctor/${doctorId}/getAppointments`); //returns array of appointments (pending && approved --maybe split up?)
  },

  RespondToPendingAppointment(appointment) {
    return axios.put('/doctor/respondToPending', appointment); //(3 statuses: pending/approved/denied)
  },
}
