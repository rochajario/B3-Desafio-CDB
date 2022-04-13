<template>
  <v-card :loading="loading" class="mx-auto my-12" max-width="500">
    <template slot="progress">
      <v-progress-linear
        color="deep-purple"
        height="10"
        indeterminate
      ></v-progress-linear>
    </template>

    <v-card-title>Cálculo do CDB</v-card-title>
    <v-divider class="mx-4"></v-divider>
    <v-card-text>
      <div>
        <v-text-field
          label="Valor do Investimento"
          v-model="investmentDto.InitialValue"
          :rules="valueRules"
          hide-details="auto"
          type="number"
        ></v-text-field>
        <v-text-field
          label="Meses Investidos"
          v-model="investmentDto.MonthsCommited"
          :rules="monthRules"
          hide-details="auto"
          type="number"
        ></v-text-field>
      </div>
    </v-card-text>

    <v-card-actions>
      <v-btn
        v-if="this.investmentDto.InitialValue == undefined || this.investmentDto.MonthsCommited == undefined"
        class="mx-4"
        color="deep-purple lighten-2"
        text
        disabled
      >
        Calcular
      </v-btn>
      <v-btn
      v-else
        class="mx-4"
        color="deep-purple lighten-2"
        text
        @click="emitInvestment"
      >
        Calcular
      </v-btn>
    </v-card-actions>
  </v-card>
</template>

<script>
export default {
  props: {
    loading: {
      type: Boolean,
      default: false,
      required: false,
    },
  },
  data: () => ({
    investmentDto: {
      InitialValue: undefined,
      MonthsCommited: undefined,
    },
    valueRules: [
      (value) => !!value || "Necessário.",
      (value) => value >= 0 || "Não pode ser menor que 0",
    ],
    monthRules: [
      (value) => !!value || "Necessário.",
      (value) => value >= 1 || "Não pode ser menor ou igual a 1.",
    ],
  }),
  methods: {
    emitInvestment() {
      if (
        this.investmentDto.InitialValue == null ||
        this.investmentDto.MonthsCommited == null
      ) {
        return;
      }
      this.$emit("onInvestmentCalculationRequest", this.investmentDto);
    },
  },
};
</script>