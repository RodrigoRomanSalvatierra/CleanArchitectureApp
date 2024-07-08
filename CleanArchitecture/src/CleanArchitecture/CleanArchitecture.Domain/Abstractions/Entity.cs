namespace CleanArchitecture.Domain.Abstractions;
public abstract class Entity{
    protected Entity(Guid id){
        id = id;
    }

    // init > indica que el identificador que se le asigne no cambiara
    public Guid Id {get; init;}
}