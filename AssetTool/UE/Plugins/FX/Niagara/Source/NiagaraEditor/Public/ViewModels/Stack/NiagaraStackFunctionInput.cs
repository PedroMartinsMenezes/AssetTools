namespace AssetTool
{
    [JsonAsset("NiagaraStackFunctionInput")]
    public class UNiagaraStackFunctionInput : UNiagaraStackItemContent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}