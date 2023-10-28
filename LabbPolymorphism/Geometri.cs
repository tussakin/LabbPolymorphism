namespace LabbPolymorphism;

// En abstrakt klass eftersom det inte ska skapas objekt som bara är Geometri, utan denna klass ska endast ärvas
public abstract class Geometri
{
    // En abstrakt metod eftersom den ska finnas i alla klasser som ärver från Geometri, men den ska vara unik för varje klass
    public abstract double Area();
}