
ARG nv=15
FROM node:$nv

# Create app directory
WORKDIR /usr/src/app

COPY package*.json ./

RUN npm ci --only=production
COPY . .

ENV PORT=3000
EXPOSE 3000

CMD [ "node", "server.js" ]