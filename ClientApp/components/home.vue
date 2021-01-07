<template>
    <div>
      <section class="container-fluid">
          <div class="row justify-content-center">
            <div class="col-lg-4">
            <div :class="loginPanel">
               <h3 :class="login">Login</h3>
                <br/> 
                 <br/>

               <form action="">
                  <div class="form-group">
                   <label for="fullName" class="input-label">Name and Surname</label> <br/>
                   <input type="text" :class="formCss" placeholder="Name and Surname:" v-model="form.fullName">
                   <p v-if="!nameIsValid" class="error-message"> The Full Name field is required! </p>
                 </div>
                 <div class="form-group">
                   <label for="email" class="input-label">Email</label> <br/>
                   <input type="email" :class="formCss" placeholder="Email:" v-model="form.email">
                   <p v-if="!emailIsValid" class="error-message"> The email field is required and must be examle email@gmail.com! </p>
                 </div>

                  <div class="form-group">
                   <label for="password" class="input-label">Password</label> <br/>
                   <input type="password" :class="formCss" placeholder="Password:" v-model="form.password">
                   <p v-if="!passwordIsValid" class="error-message"> The password field is required and must be at least 6 characters! </p>
                 </div>

                 <div class="form-group">
                   <label for="birthday">Birthday:</label> <br/>
                   <input type="date"  :class="formCss" v-model="form.birthdate">
                   <p v-if="!dateIsValid" class="error-message"> The date field is required! </p>
                 </div>




                 <button @click="signUp()"  :class="button" :disabled="!formIsValid" >Sign Up</button>
                 <button @click="loginButton()"  :class="button">Login</button>
                
 Value: {{txtValue}}
               </form>
            </div>

            </div>

          </div>




      </section>



    </div>
</template>

<script>
export default {
  data () {
    return {
      //FOR CSS
      loginPanel: 'loginPanel',
      login: 'login',
      button:'button',
      formCss: 'formCss',
         txtValue: '',

      //registeration form
      form: {
        fullName:'',
        email: '',
        password: '',
        birthdate: ''
      }

    }
  },


computed: {
  nameIsValid() {
    return !!this.form.fullName 
  },
  
  passwordIsValid(){
    const password = this.form.password
    if(password.length>=6) 
    return true
    else return false
  },

emailIsValid() {
      var re = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
      console.log(this.form.email)
     return re.test(this.form.email);
      },

  dateIsValid(){
    if(!this.form.birthdate) 
    return false
    else return true
  },

formIsValid() {
  return this.nameIsValid && this.passwordIsValid &&this.emailIsValid
}

},

methods: {

  signUp: function() {
    if(this.formIsValid) {
    this.txtValue=formIsValid
    console.log(formIsValid) }
    else {
     this.txtValue=formIsValid
    }
  }



}



}
</script>

<style>
.login{
  margin-left: 125px;
  font-size: 4em;
}
.loginPanel{
  position: relative;
  padding-top: 150px;
  margin: 8px 0;
  display: inline-flexbox;
  box-sizing: border-box;
}
.formCss{
  width: 100%;
}
.button{
  padding: 10px;
  margin-right: 8px;
 justify-content: right;
 width: 47.5%;
 background-color: #007BFF;
 color: #FFF;
}

.button:hover { 
  background: #1e0e40; 
  border: 1px #1e0e40 solid;
  }
  .error-message{
    color: red;
  }


</style>
