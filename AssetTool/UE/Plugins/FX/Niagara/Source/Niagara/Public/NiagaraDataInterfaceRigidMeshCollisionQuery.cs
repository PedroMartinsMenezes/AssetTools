namespace AssetTool
{
    [JsonAsset("NiagaraDataInterfaceRigidMeshCollisionQuery")]
    public class UNiagaraDataInterfaceRigidMeshCollisionQuery : UNiagaraDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraDIRigidMeshCollisionFunctionLibrary")]
    public class UNiagaraDIRigidMeshCollisionFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}