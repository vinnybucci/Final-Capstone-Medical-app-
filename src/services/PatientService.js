import axios from 'axios';

export default {
    GetMyInfo(patient) {
        return axios.get(`/patients/${patient.id}`); //THIS IS PROBABLY WRONG but we need something like this
    },

    UpdateMyInfo(patient) {
        return axios.push('/patients/updateInfo', patient);
    },

    GetAllOffices() {
        return axios.get('/patients/getOffices');
    },

    GetOfficeReviews(office) {
        return axios.get(`/patients/allOffices/${office.id}/reviews`);
    },

    GetReviewResponses(office) {
        return axios.get(`/patients/allOffices/${office.id}/reviews/responses`);
    },

    PostNewReview(review) {
        return axios.post(`/patients/postReview`, review);
    },

    GetAllDoctors() {
        return axios.get('/patients/getDoctors');
    },

    GetMyAppointments(patientId) {
        return axios.get(`/patients/${patientId}/appointments`);
    },

    CreateAppointmentRequest(appointment) {
        return axios.post('/patients/requestAppointment', appointment);
    },

    GetVerifiedDoctors(){
        return axios.get('/patients/getVerifiedDoctors');
    },

    GetDoctorsOffices(doctorId){
        return axios.get(`/patients/getOfficesByDoctor/${doctorId}`);
    }
}