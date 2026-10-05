using System.Text.Json.Serialization;

namespace AssetTool
{
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "__type")]
    [JsonDerivedType(typeof(FRigTransformElement), nameof(FRigTransformElement))]
    [JsonDerivedType(typeof(FRigSingleParentElement), nameof(FRigSingleParentElement))]
    [JsonDerivedType(typeof(FRigBoneElement), nameof(FRigBoneElement))]
    [JsonDerivedType(typeof(FRigReferenceElement), nameof(FRigReferenceElement))]
    [JsonDerivedType(typeof(FRigMultiParentElement), nameof(FRigMultiParentElement))]
    [JsonDerivedType(typeof(FRigNullElement), nameof(FRigNullElement))]
    [JsonDerivedType(typeof(FRigControlElement), nameof(FRigControlElement))]
    [JsonDerivedType(typeof(FRigCurveElement), nameof(FRigCurveElement))]
    [JsonDerivedType(typeof(FRigPhysicsElement), nameof(FRigPhysicsElement))]
    [JsonDerivedType(typeof(FRigConnectorElement), nameof(FRigConnectorElement))]
    [JsonDerivedType(typeof(FRigSocketElement), nameof(FRigSocketElement))]
    public class FRigBaseElement : ITransferable<ESerializationPhase>
    {
        protected ESerializationPhase SerializationPhase;
        public FRigElementKey LoadedKey;
        public Int32 MetadataNum;
        public List<FName> MetadataNames;
        public List<FName> MetadataTypeNames;
        public List<FRigBaseMetadata> Mds;

        public virtual ITransferable Move(Transfer transfer, ESerializationPhase serializationPhase)
        {
            SerializationPhase = serializationPhase;
            return Move(transfer);
        }

        [Location("void FRigBaseElement::Load(FArchive& Ar, ESerializationPhase SerializationPhase)")]
        public virtual ITransferable Move(Transfer transfer)
        {
            if (SerializationPhase == ESerializationPhase.StaticData)
            {
                transfer.Move(ref LoadedKey);
                if (transfer.Supports.HierarchyElementMetadata && !transfer.Supports.RigHierarchyStoresElementMetadata)
                {
                    transfer.Move(ref MetadataNum);

                    transfer.Resize(ref MetadataNames, MetadataNum);
                    transfer.Resize(ref MetadataTypeNames, MetadataNum);
                    transfer.Resize(ref Mds, MetadataNum);

                    for (int MetadataIndex = 0; MetadataIndex < MetadataNum; MetadataIndex++)
                    {
                        MetadataNames[MetadataIndex].Move(transfer);
                        MetadataTypeNames[MetadataIndex].Move(transfer);
                        Mds[MetadataIndex].Move(transfer);
                    }
                }
            }
            return this;
        }
    }

    public class FRigTransformElement : FRigBaseElement
    {
        public FRigCurrentAndInitialTransform Pose;

        [Location("void FRigTransformElement::Load(FArchive& Ar, ESerializationPhase SerializationPhase)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            if (SerializationPhase == ESerializationPhase.StaticData)
            {
                transfer.Move(ref Pose);
            }
            return this;
        }
    }

    public class FRigSingleParentElement : FRigTransformElement
    {
        public FRigElementKey ParentKey;

        [Location("void FRigSingleParentElement::Load(FArchive& Ar, ESerializationPhase SerializationPhase)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            if (SerializationPhase == ESerializationPhase.InterElementData)
            {
                transfer.Move(ref ParentKey);
            }
            return this;
        }
    }

    public class FRigBoneElement : FRigSingleParentElement
    {
        public FName TypeName;

        [Location("void FRigBoneElement::Load(FArchive& Ar, URigHierarchy* Hierarchy, ESerializationPhase SerializationPhase)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            if (SerializationPhase == ESerializationPhase.StaticData)
            {
                transfer.Move(ref TypeName);
            }
            return this;
        }
    }

    public class FRigCurrentAndInitialTransform : ITransferable
    {
        public FRigLocalAndGlobalTransform Current;
        public FRigLocalAndGlobalTransform Initial;

        [Location("void FRigCurrentAndInitialTransform::Load(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Current);
            transfer.Move(ref Initial);
            return this;
        }
    }

    public class FRigLocalAndGlobalTransform : ITransferable
    {
        public FRigComputedTransform Local;
        public FRigComputedTransform Global;

        [Location("void FRigLocalAndGlobalTransform::Load(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Local);
            transfer.Move(ref Global);
            return this;
        }
    }

    public class FRigComputedTransform : ITransferable
    {
        public FTransform Transform;
        public bool bDirty;

        [Location("void FRigComputedTransform::Save(FArchive& Ar, bool& bDirty)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Transform);
            transfer.Move(ref bDirty);
            return this;
        }
    }

    public class FRigNullElement : FRigMultiParentElement
    {

    }

    public class FRigMultiParentElement : FRigTransformElement
    {
        public FRigCurrentAndInitialTransform Parent;
        public Int32 NumParents;
        public List<FRigElementParentConstraint> ParentConstraints;
        public List<FRigElementKey> ParentKeys;

        [Location("void FRigMultiParentElement::Load(FArchive& Ar, URigHierarchy* Hierarchy, ESerializationPhase SerializationPhase)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            if (SerializationPhase == ESerializationPhase.StaticData)
            {
                if (!transfer.Supports.RemovedMultiParentParentCache)
                {
                    transfer.Move(ref Parent);
                }
                transfer.Move(ref NumParents);
                transfer.Resize(ref ParentConstraints, NumParents);
            }
            else if (SerializationPhase == ESerializationPhase.InterElementData)
            {
                transfer.Resize(ref ParentKeys, ParentConstraints.Count);

                for (int ParentIndex = 0; ParentIndex < ParentConstraints.Count; ParentIndex++)
                {
                    ParentKeys[ParentIndex].Move(transfer);

                    if (transfer.Supports.RigHierarchyMultiParentConstraints)
                    {
                        transfer.Move(ref ParentConstraints[ParentIndex].InitialWeight);
                        transfer.Move(ref ParentConstraints[ParentIndex].Weight);
                    }
                    else
                    {
                        ParentConstraints[ParentIndex].InitialWeight.MoveFloat(transfer);
                        ParentConstraints[ParentIndex].Weight.MoveFloat(transfer);
                    }
                }
            }
            return this;
        }
    }

    public class FRigElementParentConstraint
    {
        public FRigTransformElement ParentElement;
        public FRigElementWeight InitialWeight = new();
        public FRigElementWeight Weight = new();
    }

    public class FRigElementWeight : ITransferable
    {
        public float Location;
        public float Rotation;
        public float Scale;

        [Location("friend FArchive& operator <<(FArchive& Ar, FRigElementWeight& Weight)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Location);
            transfer.Move(ref Rotation);
            transfer.Move(ref Scale);
            return this;
        }

        public ITransferable MoveFloat(Transfer transfer)
        {
            transfer.Move(ref Location);
            Rotation = Location;
            Scale = Location;
            return this;
        }
    }

    public class FRigControlElement : FRigMultiParentElement
    {
        public FRigControlSettings Settings;
        public FRigCurrentAndInitialTransform Offset;
        public FRigCurrentAndInitialTransform Shape;
        public FRigPreferredEulerAngles PreferredEulerAngles;

        [Location("void FRigControlElement::Load(FArchive& Ar, URigHierarchy* Hierarchy, ESerializationPhase SerializationPhase)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            if (SerializationPhase == ESerializationPhase.StaticData)
            {
                transfer.Move(ref Settings);
                transfer.Move(ref Offset);
                transfer.Move(ref Shape);

                if (transfer.Supports.PreferredEulerAnglesForControls)
                {
                    transfer.Move(ref PreferredEulerAngles);
                }
            }
            return this;
        }
    }

    public class FRigControlSettings : ITransferable
    {
        public FName AnimationTypeName;
        public FName ControlTypeName;
        public FName DisplayName;
        public FName PrimaryAxisName;
        public bool bIsCurve;
        public bool bAnimatableDeprecated;
        public bool bLimitTranslation_DEPRECATED;
        public bool bLimitRotation_DEPRECATED;
        public bool bLimitScale_DEPRECATED;
        public List<FRigControlLimitEnabled> LimitEnabled;
        public bool bDrawLimits;
        public FRigControlValue MinimumValue;
        public FRigControlValue MaximumValue;
        public FTransform MinimumTransform;
        public FTransform MaximumTransform;
        public bool bShapeEnabledDeprecated;
        public bool bShapeVisible;
        public FName ShapeVisibilityName;
        public FName ShapeName;
        public FLinearColor ShapeColor;
        public bool bIsTransientControl;
        public FString ControlEnumPathName;
        public FRigControlElementCustomization Customization = new();
        public List<FRigElementKey> DrivenControls;
        public bool bGroupWithParentControl;
        public bool bRestrictSpaceSwitching;
        public ERigControlTransformChannel[] FilteredChannels;
        public EEulerRotationOrder PreferredRotationOrder;
        public bool bUsePreferredRotationOrder;

        [Location("void FRigControlSettings::Load(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            if (transfer.Supports.ControlAnimationType)
            {
                transfer.Move(ref AnimationTypeName);
            }
            transfer.Move(ref ControlTypeName);
            transfer.Move(ref DisplayName);
            transfer.Move(ref PrimaryAxisName);
            transfer.Move(ref bIsCurve);
            if (!transfer.Supports.ControlAnimationType)
            {
                transfer.Move(ref bAnimatableDeprecated);
            }
            if (!transfer.Supports.PerChannelLimits)
            {
                transfer.Move(ref bLimitTranslation_DEPRECATED);
                transfer.Move(ref bLimitRotation_DEPRECATED);
                transfer.Move(ref bLimitScale_DEPRECATED);
            }
            else
            {
                transfer.Move(ref LimitEnabled);
            }
            transfer.Move(ref bDrawLimits);

            if (transfer.Supports.StorageMinMaxValuesAsFloatStorage)
            {
                transfer.Move(ref MinimumValue);
                transfer.Move(ref MaximumValue);
            }
            else
            {
                transfer.Move(ref MinimumTransform);
                transfer.Move(ref MaximumTransform);
            }

            if (!transfer.Supports.ControlAnimationType)
            {
                transfer.Move(ref bShapeEnabledDeprecated);
            }

            transfer.Move(ref bShapeVisible);

            if (transfer.Supports.ControlAnimationType)
            {
                transfer.Move(ref ShapeVisibilityName);
            }
            transfer.Move(ref ShapeName);

            transfer.Move(ref ShapeColor);
            transfer.Move(ref bIsTransientControl);
            transfer.Move(ref ControlEnumPathName);

            if (transfer.Supports.RigHierarchyControlSpaceFavorites)
            {
                transfer.Move(ref Customization.AvailableSpaces);
            }

            if (transfer.Supports.ControlAnimationType)
            {
                transfer.Move(ref DrivenControls);
            }

            if (transfer.Supports.ControlAnimationType)
            {
                transfer.Move(ref bGroupWithParentControl);
            }

            if (transfer.Supports.RestrictSpaceSwitchingForControls)
            {
                transfer.Move(ref bRestrictSpaceSwitching);
            }

            if (transfer.Supports.ControlTransformChannelFiltering)
            {
                transfer.MoveEnum(ref FilteredChannels);
            }

            if (transfer.Supports.RigHierarchyControlPreferredRotationOrder)
                transfer.MoveEnum(ref PreferredRotationOrder);

            if (transfer.Supports.RigHierarchyControlPreferredRotationOrderFlag)
                transfer.Move(ref bUsePreferredRotationOrder);

            return this;
        }
    }

    public class FRigPreferredEulerAngles : ITransferable
    {
        public FName RotationOrderName;
        public FVector Current;
        public FVector Initial;

        [Location("void FRigPreferredEulerAngles::Load(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref RotationOrderName);
            transfer.Move(ref Current);
            transfer.Move(ref Initial);
            return this;
        }
    }

    public class FRigControlElementCustomization
    {
        public List<FRigElementKey> AvailableSpaces = [];
        public List<FRigElementKey> RemovedSpaces = [];
    }

    public class FRigCurveElement : FRigBaseElement
    {
        public bool bIsValueSet;
        public float Value;

        [Location("void FRigCurveElement::Load(FArchive& Ar, URigHierarchy* Hierarchy, ESerializationPhase SerializationPhase)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            if (SerializationPhase == ESerializationPhase.StaticData)
            {
                if (transfer.Supports.CurveElementValueStateFlag)
                {
                    transfer.Move(ref bIsValueSet);
                }
                transfer.Move(ref Value);
            }
            return this;
        }
    }

    public class FRigPhysicsElement : FRigSingleParentElement
    {
        public FRigPhysicsSolverID Solver;
        public FRigPhysicsSettings Settings;

        [Location("void FRigPhysicsElement::Load(FArchive& Ar, ESerializationPhase SerializationPhase)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            if (SerializationPhase == ESerializationPhase.StaticData)
            {
                transfer.Move(ref Solver);
                transfer.Move(ref Settings);
            }
            return this;
        }
    }

    public class FRigPhysicsSolverID : ITransferable
    {
        public FGuid Guid;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Guid);
            return this;
        }
    }

    public class FRigPhysicsSettings : ITransferable
    {
        public float Mass;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Mass);
            return this;
        }
    }

    public class FRigRigidBodySettings : ITransferable
    {
        public float Mass;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Mass);
            return this;
        }
    }

    public class FRigReferenceElement : FRigSingleParentElement
    {
        [Location("void FRigReferenceElement::Load(FArchive& Ar, URigHierarchy* Hierarchy, ESerializationPhase SerializationPhase)")]
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    public class FRigConnectorElement : FRigBaseElement
    {
        public FRigConnectorSettings Settings;

        [Location("void FRigConnectorElement::Load(FArchive& Ar, ESerializationPhase SerializationPhase)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            if (SerializationPhase == ESerializationPhase.StaticData)
            {
                transfer.Move(ref Settings);
            }
            return this;
        }
    }

    public class FRigConnectorSettings : ITransferable
    {
        public FString Description;
        public EConnectorType Type;
        public bool bOptional;
        public List<FRigConnectionRuleStash> Rules;

        [Location("void FRigConnectorSettings::Load(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Description);
            if (transfer.Supports.ConnectorsWithType)
            {
                transfer.MoveEnum(ref Type);
                transfer.Move(ref bOptional);
            }
            transfer.Move(ref Rules);
            return this;
        }
    }

    public class FRigSocketElement : FRigSingleParentElement
    {

        [Location("void FRigSocketElement::Load(FArchive& Ar, ESerializationPhase SerializationPhase)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }

    public class FRigPhysicsSolverDescription : ITransferable
    {
        public FRigPhysicsSolverID ID;
        public FName Name;

        [Location("void FRigPhysicsSolverDescription::Load(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref ID);
            transfer.Move(ref Name);
            return this;
        }
    }

    public enum EConnectorType : uint8
    {
        Primary,
        Secondary,
    }

    public enum ESerializationPhase
    {
        StaticData,
        InterElementData
    }

    public enum ERigControlTransformChannel : byte
    {
        TranslationX,
        TranslationY,
        TranslationZ,
        Pitch,
        Yaw,
        Roll,
        ScaleX,
        ScaleY,
        ScaleZ
    }
}
