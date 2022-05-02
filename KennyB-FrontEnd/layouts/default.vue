<template>
  <v-app dark>
    <v-container class="container">
      <TheHeader />
      <TheMenu />
      <Nuxt />
      <TheFooter class="footer" />
    </v-container>
  </v-app>
</template>

<script>
export default {
  name: 'DefaultLayout',
  data () {
    return {

    }
  }
}
</script>
<style scoped>
.main-content{
  width: 80%;
margin-left:auto;
margin-right:auto;
}
.container {
  display: flex;
  flex-direction: column;
  height: 100%;
}
</style>
