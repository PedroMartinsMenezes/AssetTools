namespace AssetTool
{
    [JsonAsset("NiagaraNodeCustomHlsl")]
    public class UNiagaraNodeCustomHlsl : UNiagaraNodeFunctionCall
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}