<template>
  <v-app>
    <v-main class="align-center">
      <investment-form
        :loading="this.processingRequest"
        @onInvestmentCalculationRequest="newInvestment"
      />
      <investment-results :result="this.investmentBusinessEntity" />
      <snackbar-http-status
        :color="snackbarColor"
        :text="snackbarMessage"
        :visible="snackbarVisibility"
      />
    </v-main>
  </v-app>
</template>

<script>
import Form from "./components/Form.vue";
import Results from "./components/Results.vue";
import SnackbarMixinVue from "./components/SnackbarMixin.vue";
import SnackBarVue from "./components/SnackBar.vue";

export default {
  name: "App",
  mixins: [SnackbarMixinVue],
  components: {
    "investment-form": Form,
    "investment-results": Results,
    "snackbar-http-status": SnackBarVue,
  },
  methods: {
    newInvestment(dto) {
      this.getInvestmentEntity(dto);
    },
    getInvestmentEntity(dto) {
      this.processingRequest = true;

      this.$ApiService.calculateInvestment(dto)
        .then((res) => {
          this.setInvestmentEntity(res.data);
          this.showSuccess("CDB Calculado com Sucesso!");
        })
        .catch((err) => {
          this.showError(`Ops... ${err.message}`);
        })
        .finally(() => {
          this.processingRequest = false;
        });
    },
    setInvestmentEntity(entity) {
      this.investmentBusinessEntity.object = entity;
      this.investmentBusinessEntity.fullfilled = true;
    },
  },
  data: () => ({
    investmentBusinessEntity: {
      fullfilled: false,
      object: undefined,
    },
    processingRequest: false
  })
};
</script>
