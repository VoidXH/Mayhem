﻿using UnityEngine;

using Helpers;

namespace Weapons {
    public class Photon : WeaponBase {
        protected override void Setup() {
            _Kind = WeaponKinds.Photon;
            _DisplayName = "PHOTON";
        }

        protected override void Shoot() {
            float Width = (Level - 1) * -1.25f;
            for (int i = 0; i < Level; i++) {
                Projectile projectile = Instantiate(PlayerEntity.Instance.ProjectileEntity, transform.position + new Vector3(Width, 0, 12), transform.rotation)
                    .GetComponent<Projectile>();
                Width += 2.5f;
                projectile.Player = true;
                projectile.Damage = 3;
                projectile.WeaponKind = WeaponKinds.Photon;
                projectile.GetComponentInChildren<Renderer>().material.color = Color.green;
                projectile.transform.localScale += new Vector3(1, 1, 0);
            }
            PlayerEntity.Instance.PlaySound(PlayerEntity.Instance.AudioPhoton, .5f);
        }
    }
}