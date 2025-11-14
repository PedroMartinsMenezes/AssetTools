namespace AssetTool
{
    [JsonAsset("NiagaraNodeConvert")]
    public class UNiagaraNodeConvert : UNiagaraNodeWithDynamicPins
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}