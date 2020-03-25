﻿using Altseed;
using static Tutorial.Resources;

namespace Tutorial
{
    public sealed class PlayerBullet : Bullet
    {
        /// <summary>
        /// 弾の移動量/フレーム
        /// </summary>
        private readonly static Vector2F velocity = new Vector2F(10f, 0.0f);

        /// <summary>
        /// 新しいインスタンスを生成する
        /// </summary>
        /// <param name="position">座標</param>
        public PlayerBullet(Vector2F position) : base(position, velocity)
        {
            Texture = Texture_Bullet_Blue;
            CenterPosition = Texture.Size / 2;
            Radius = Texture.Size.X / 2;
        }

        protected override void OnCollision(CollidableObject obj)
        {
            if (obj is Enemy) Parent?.RemoveChildNode(this);
        }
    }
}