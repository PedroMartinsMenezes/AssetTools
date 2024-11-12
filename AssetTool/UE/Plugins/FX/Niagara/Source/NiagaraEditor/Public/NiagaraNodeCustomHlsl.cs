namespace AssetTool
{
    [JsonAsset("NiagaraNodeCustomHlsl")]
    public class UNiagaraNodeCustomHlsl : UNiagaraNodeFunctionCall
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}