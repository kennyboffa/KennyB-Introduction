<template>
  <div>
    <v-app-bar
      elevation="4"
      flat
      rounded
      color="gray"
    >
      <v-tabs fixed-tabs>
        <v-tab nuxt to="/">
          Introduction
        </v-tab>

        <v-tab nuxt to="/mycv">
          My Resumé/CV
        </v-tab>
        <v-tab nuxt to="/leave-comment">
          Message me
        </v-tab>
      </v-tabs>
    </v-app-bar>
  </div>
</template>

<script>
export default {

}
</script>

<style>

</style>
