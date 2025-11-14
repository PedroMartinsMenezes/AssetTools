namespace AssetTool
{
    [JsonAsset("NiagaraNodeCustomHlsl")]
    public class UNiagaraNodeCustomHlsl : UNiagaraNodeFunctionCall
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}