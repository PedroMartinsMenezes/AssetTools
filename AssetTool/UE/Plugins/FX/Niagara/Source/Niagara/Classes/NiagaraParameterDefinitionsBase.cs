namespace AssetTool
{
    [JsonAsset("NiagaraParameterDefinitionsBase")]
    public class UNiagaraParameterDefinitionsBase : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}