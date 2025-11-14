namespace AssetTool
{
    [JsonAsset("NiagaraNodeInput")]
    public class UNiagaraNodeInput : UNiagaraNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}