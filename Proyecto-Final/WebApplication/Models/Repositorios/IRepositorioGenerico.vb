Public Interface IRepositorioGenerico(Of TEntity As Class)

    Function agregar(ByVal entidad As TEntity) As Boolean
    Function eliminar(ByVal entidad As TEntity) As Boolean
    Function actualizar(ByVal entidad As TEntity) As Boolean
    Function buscarPorID(ByVal id As Integer) As TEntity
    Function seleccionarTodas() As IEnumerable(Of TEntity)

End Interface