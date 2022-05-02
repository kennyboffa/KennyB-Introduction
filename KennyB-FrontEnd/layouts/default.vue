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
.container {
  display: flex;
  flex-direction: column;
  height: 100%;
}
</style>
