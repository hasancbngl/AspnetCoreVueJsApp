<template>
    <div>
      <section class="container-fluid">
          <div class="row justify-content-center">
            <div class="col-lg-4">
            <div :class="loginPanel">
               <h3 :class="login"></h3>
                <br/> 
                 <br/>

               <form action="">
                 <div class="form-group">
                   <label for="email" class="input-label">Email</label> <br/>
                   <input type="email" :class="formCss" placeholder="Email:" v-model="form.email">
                   <p v-if="!emailIsValid" class="error-message"> The email field is required and must be examle email@gmail.com! </p>
                 </div>

                  <div class="form-group">
                   <label for="password" class="input-label">Password</label> <br/>
                   <input type="password" :class="formCss" placeholder="Password:" v-model="form.password">
                   <p v-if="!passwordIsValid" class="error-message"> The password field is required! </p>
                 </div>

                 <button @click="logIn()"  :class="button" :disabled="!formIsValid" >Login</button>
                 <button @click="signUp()"  :class="button">Sign Up</button>
                
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

      //registeration form
      form: {
        email: '',
        password: '',
      }

    }
  },


computed: {

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

formIsValid() {
  return  this.passwordIsValid &&this.emailIsValid
}

},

methods: {

  logIn: function() {
    if(this.formIsValid) {
    try{ 
       this.$http.post('/api/login/', {
        form:this.form
                    
                }).then(function (response) {
                    console.log(response)
                })   
    } catch(error) {
      console.log(error)
    }  
      }
    else {
     this.txtValue=formIsValid
    }
  },

   signUp: function() {
   this.$router.push('/') 
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
