class Motor {
    private int litros_de_aceite;
    private int potencia;

    public Motor(int potencia) {
        this.potencia = potencia;
        this.litros_de_aceite = 0;
    }

    public int getLitros_de_aceite() {
        return litros_de_aceite;
    }

    public void setLitros_de_aceite(int litros_de_aceite) {
        this.litros_de_aceite = litros_de_aceite;
    }

    public int getPotencia() {
        return potencia;
    }

    public void setPotencia(int potencia) {
        this.potencia = potencia;
    }
}