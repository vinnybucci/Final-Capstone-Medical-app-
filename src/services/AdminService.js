import axios from 'axios';

export default {

  GetPendingDoctors() {
    return axios.get('/admin/getPendingDoctors');
  },

  CreateNewOffice(office) {
    return axios.post('/admin/createNewOffice', office);
  },

  ChangeDoctorStatus(doctor) {
    return axios.put('/admin/approveDoctorUser', doctor);
  }
}