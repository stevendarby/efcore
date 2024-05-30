// <auto-generated />
using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Scaffolding;

#pragma warning disable 219, 612, 618
#nullable disable

namespace Scaffolding
{
    [EntityFrameworkInternal]
    public partial class IdentityUser0EntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelInMemoryTest+IdentityUser",
                typeof(CompiledModelInMemoryTest.IdentityUser),
                baseEntityType,
                discriminatorProperty: "Discriminator",
                discriminatorValue: "DerivedIdentityUser",
                propertyCount: 0);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            var id = runtimeEntityType.FindProperty("Id")!;
            var accessFailedCount = runtimeEntityType.FindProperty("AccessFailedCount")!;
            var concurrencyStamp = runtimeEntityType.FindProperty("ConcurrencyStamp")!;
            var discriminator = runtimeEntityType.FindProperty("Discriminator")!;
            var email = runtimeEntityType.FindProperty("Email")!;
            var emailConfirmed = runtimeEntityType.FindProperty("EmailConfirmed")!;
            var lockoutEnabled = runtimeEntityType.FindProperty("LockoutEnabled")!;
            var lockoutEnd = runtimeEntityType.FindProperty("LockoutEnd")!;
            var normalizedEmail = runtimeEntityType.FindProperty("NormalizedEmail")!;
            var normalizedUserName = runtimeEntityType.FindProperty("NormalizedUserName")!;
            var passwordHash = runtimeEntityType.FindProperty("PasswordHash")!;
            var phoneNumber = runtimeEntityType.FindProperty("PhoneNumber")!;
            var phoneNumberConfirmed = runtimeEntityType.FindProperty("PhoneNumberConfirmed")!;
            var securityStamp = runtimeEntityType.FindProperty("SecurityStamp")!;
            var twoFactorEnabled = runtimeEntityType.FindProperty("TwoFactorEnabled")!;
            var userName = runtimeEntityType.FindProperty("UserName")!;
            runtimeEntityType.SetOriginalValuesFactory(
                (InternalEntityEntry source) =>
                {
                    var entity = (CompiledModelInMemoryTest.IdentityUser)source.Entity;
                    return (ISnapshot)new Snapshot<string, int, string, string, string, bool, bool, Nullable<DateTimeOffset>, string, string, string, string, bool, string, bool, string>(source.GetCurrentValue<string>(id) == null ? null : ((ValueComparer<string>)((IProperty)id).GetValueComparer()).Snapshot(source.GetCurrentValue<string>(id)), ((ValueComparer<int>)((IProperty)accessFailedCount).GetValueComparer()).Snapshot(source.GetCurrentValue<int>(accessFailedCount)), source.GetCurrentValue<string>(concurrencyStamp) == null ? null : ((ValueComparer<string>)((IProperty)concurrencyStamp).GetValueComparer()).Snapshot(source.GetCurrentValue<string>(concurrencyStamp)), source.GetCurrentValue<string>(discriminator) == null ? null : ((ValueComparer<string>)((IProperty)discriminator).GetValueComparer()).Snapshot(source.GetCurrentValue<string>(discriminator)), source.GetCurrentValue<string>(email) == null ? null : ((ValueComparer<string>)((IProperty)email).GetValueComparer()).Snapshot(source.GetCurrentValue<string>(email)), ((ValueComparer<bool>)((IProperty)emailConfirmed).GetValueComparer()).Snapshot(source.GetCurrentValue<bool>(emailConfirmed)), ((ValueComparer<bool>)((IProperty)lockoutEnabled).GetValueComparer()).Snapshot(source.GetCurrentValue<bool>(lockoutEnabled)), source.GetCurrentValue<Nullable<DateTimeOffset>>(lockoutEnd) == null ? null : ((ValueComparer<Nullable<DateTimeOffset>>)((IProperty)lockoutEnd).GetValueComparer()).Snapshot(source.GetCurrentValue<Nullable<DateTimeOffset>>(lockoutEnd)), source.GetCurrentValue<string>(normalizedEmail) == null ? null : ((ValueComparer<string>)((IProperty)normalizedEmail).GetValueComparer()).Snapshot(source.GetCurrentValue<string>(normalizedEmail)), source.GetCurrentValue<string>(normalizedUserName) == null ? null : ((ValueComparer<string>)((IProperty)normalizedUserName).GetValueComparer()).Snapshot(source.GetCurrentValue<string>(normalizedUserName)), source.GetCurrentValue<string>(passwordHash) == null ? null : ((ValueComparer<string>)((IProperty)passwordHash).GetValueComparer()).Snapshot(source.GetCurrentValue<string>(passwordHash)), source.GetCurrentValue<string>(phoneNumber) == null ? null : ((ValueComparer<string>)((IProperty)phoneNumber).GetValueComparer()).Snapshot(source.GetCurrentValue<string>(phoneNumber)), ((ValueComparer<bool>)((IProperty)phoneNumberConfirmed).GetValueComparer()).Snapshot(source.GetCurrentValue<bool>(phoneNumberConfirmed)), source.GetCurrentValue<string>(securityStamp) == null ? null : ((ValueComparer<string>)((IProperty)securityStamp).GetValueComparer()).Snapshot(source.GetCurrentValue<string>(securityStamp)), ((ValueComparer<bool>)((IProperty)twoFactorEnabled).GetValueComparer()).Snapshot(source.GetCurrentValue<bool>(twoFactorEnabled)), source.GetCurrentValue<string>(userName) == null ? null : ((ValueComparer<string>)((IProperty)userName).GetValueComparer()).Snapshot(source.GetCurrentValue<string>(userName)));
                });
            runtimeEntityType.SetStoreGeneratedValuesFactory(
                () => Snapshot.Empty);
            runtimeEntityType.SetTemporaryValuesFactory(
                (InternalEntityEntry source) => Snapshot.Empty);
            runtimeEntityType.SetShadowValuesFactory(
                (IDictionary<string, object> source) => (ISnapshot)new Snapshot<string>(source.ContainsKey("Discriminator") ? (string)source["Discriminator"] : null));
            runtimeEntityType.SetEmptyShadowValuesFactory(
                () => (ISnapshot)new Snapshot<string>(default(string)));
            runtimeEntityType.SetRelationshipSnapshotFactory(
                (InternalEntityEntry source) =>
                {
                    var entity = (CompiledModelInMemoryTest.IdentityUser)source.Entity;
                    return (ISnapshot)new Snapshot<string>(source.GetCurrentValue<string>(id) == null ? null : ((ValueComparer<string>)((IProperty)id).GetKeyValueComparer()).Snapshot(source.GetCurrentValue<string>(id)));
                });
            runtimeEntityType.Counts = new PropertyCounts(
                propertyCount: 16,
                navigationCount: 0,
                complexPropertyCount: 0,
                originalValueCount: 16,
                shadowCount: 1,
                relationshipCount: 1,
                storeGeneratedCount: 0);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
