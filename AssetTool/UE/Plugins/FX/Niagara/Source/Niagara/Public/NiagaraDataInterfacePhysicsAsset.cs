namespace AssetTool
{
    [JsonAsset("NiagaraDataInterfacePhysicsAsset")]
    public class UNiagaraDataInterfacePhysicsAsset : UNiagaraDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}