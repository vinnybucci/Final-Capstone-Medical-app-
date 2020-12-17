<template>
  <div id="app">
    <div id="nav">
     <router-link class="homeBtn" v-bind:to="{ name: 'home' }"></router-link>&nbsp;&nbsp;
    <router-link class="logoutBtn" v-bind:to="{ name: 'logout' }" v-if="$store.state.token != ''"></router-link>
    </div>
    <router-view />
    
  </div>
</template>



<style scoped>
#app{
         background-color: white
}
#nav{
  border: 2px solid black;
  background-image: linear-gradient(
    to bottom right,
    rgb(71, 71, 71),
    rgb(216, 216, 216)
  );
}
.homeBtn {
  font-family: "Courier", impact, monospace;
  color: black;
  border: 2px solid rgb(0, 0, 0);
  border-radius: 20px;
  background-image: linear-gradient(
    to bottom right,
    rgb(255, 255, 255),
    rgb(228, 228, 228)
  );
  height: 22px;
  width: 60px;
  top:1.25%;
  left:1.8%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
}
.homeBtn:before {
  content: "Home";
 
  padding-left:25px ;
  width: 86px;
    top:50%;
  left:50%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
.homeBtn:after {
  content: "ホーム";
  padding-left:21px;
  padding-top: 3px;
  width: 86px;
    top:50%;
  left:50%;
  transform: translate(-50%, -50%);
  position: absolute;
  top: 140%;
  transition: 0.5s;
}
.homeBtn:hover:before {
  top: -50%;
}
.homeBtn:hover:after {
  top: 50%;
}


.logoutBtn {
  font-family: "Courier", impact, monospace;
  color: black;
  border: 2px solid rgb(0, 0, 0);
  border-radius: 20px;
  background-image: linear-gradient(
    to bottom right,
    rgb(255, 255, 255),
    rgb(228, 228, 228)
  );
  height: 22px;
  width: 90px;
  top:1.25%;
  left:6%;
  position: absolute;
  transform: translate(-50%, -50%);
  overflow: hidden;
 
}
.logoutBtn:before {
  content: "Logout";
 
  padding-left:16px ;
  width: 86px;
    top:50%;
  left:50%;
  transform: translate(-50%, -50%);
  position: absolute;
  transition: 0.5s;
}
.logoutBtn:after {
  content: "ログアウト";
  padding-left:10px;
  padding-top: 3px;
  width: 100px;
    top:50%;
  left:50%;
  transform: translate(-50%, -50%);
  position: absolute;
  top: 140%;
  transition: 0.5s;
}
.logoutBtn:hover:before {
  top: -50%;
}
.logoutBtn:hover:after {
  top: 50%;
}
</style>
