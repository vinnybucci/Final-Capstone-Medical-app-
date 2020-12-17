<template>
<div class="loginPage">
  <div id="login" class="text-center">
    <form class="form-signin" @submit.prevent="login">
      <h1 class="h3 mb-3 font-weight-normal" id="welcomeSign">Please Sign In</h1>
      <div
        class="alert alert-danger"
        role="alert"
        v-if="invalidCredentials"
      >Invalid username and password!</div>
      <div
        class="alert alert-success"
        role="alert"
        v-if="this.$route.query.registration"
      >Thank you for registering, please sign in.</div>
      <label for="username" class="sr-only">Username</label>
      <input
        type="text"
        id="username"
        class="form-control"
        placeholder="Username || ユーザー名"
        v-model="user.username"
        required
        autofocus
      />
      <label for="password" class="sr-only">Password</label>
      <input
        type="password"
        id="password"
        class="form-control"
        placeholder="Password || パスワード"
        v-model="user.password"
        required
      />
     <router-link :to="{ name: 'register' }" class="register">Need an account? || アカウントが必要です？</router-link>
      <button type="submit" class="submitLoginBtn"></button>
    </form>
  </div>
  <dr-Mario-Img/>
</div>
</template>

<script>
import authService from "../services/AuthService";
import drMarioImg from '../components/DrMarioImg.vue';

export default {
  name: "login",
  components: {
    drMarioImg
  },
  data() {
    return {
      user: {
        username: "",
        password: "",
       
      },
      invalidCredentials: false
    };
  },
  methods: {
    login() {
      authService
        .login(this.user)
        .then(response => {
          if (response.status == 200) {
            this.$store.commit("SET_AUTH_TOKEN", response.data.token);
            this.$store.commit("SET_USER", response.data.user);
            if(this.$store.state.user.role == "admin") {
              this.$router.push("adminHome");
            }
            else if(this.$store.state.user.role == "doctorVerified") {
              this.$router.push("viewSchedule");
            }
            else if (this.$store.state.user.role == "patient") {
              this.$store.commit("SET_APPOINTMENTS");
              this.$router.push("patient");
            }
            else {
              this.$router.push("unverifiedDoctor");
            }
          }
        })
        .catch(error => {
          const response = error.response;

          if (response.status === 401) {
            this.invalidCredentials = true;
          }
        });
    }
  }
};
</script>
<style scoped>
.loginPage{
  padding-top:80px;
}
.register{
  margin-right: 280px;
  text-decoration: underline;
}

#welcomeSign {
  font-family: "Courier", impact, monospace;
  color: black;
  border: 2px solid rgb(0, 0, 0);
  border-radius: 20px;
  background-image: linear-gradient(
    to bottom right,
    rgb(255, 255, 255),
    rgb(228, 228, 228)
  );
  padding-top:7px ;
  padding-left:140px ;
  height: 50px;
  width: 430px;
  top:6%;
  left:50%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
 
}
#welcomeSign:before {
  content: "Welcome,";
 
  padding-left:1px ;
  width: 500px;
    top:50%;
  left:21%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
#welcomeSign:after {
  content: "医師,";
   padding-top:3px ;
   padding-right: 20px;
  width: 500px;
    top:50%;
  left:30%;
  transform: translate(-50%, -50%);
  position: absolute;
  top: 140%;
  transition: 0.5s;
}
#welcomeSign:hover:before {
  top: -50%;
}
#welcomeSign:hover:after {
  top: 50%;
}


.submitLoginBtn {
  font-family: "Courier", impact, monospace;
  color: black;
  border: 2px solid rgb(0, 0, 0);
  border-radius: 20px;
  background-image:url("../img/pill2.jpg");
       background-size:cover;
        background-repeat: no-repeat;
        
  height: 22px;
  width: 100px;
  top:20.4%;
  left:55%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
}
.submitLoginBtn:before {
  content: "Sign in";
  padding-top: 2px;
  padding-left:25px ;
  width: 100px;
    top:50%;
  left:38%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
.submitLoginBtn:after {
  content: "サインイン";
  padding-left:21px;
  padding-top: 4px;
  width: 150px;
    top:50%;
  left:40%;
  transform: translate(-50%, -50%);
  position: absolute;
  top: 140%;
  transition: 0.5s;
}
.submitLoginBtn:hover:before {
  top: -50%;
}
.submitLoginBtn:hover:after {
  top: 50%;
}

</style>
